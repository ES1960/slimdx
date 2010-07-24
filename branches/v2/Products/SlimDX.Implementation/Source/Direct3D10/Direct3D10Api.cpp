#include "stdafx.h"

#include "Direct3D10Api.h"
#include "Direct3D10Recorder.h"

#include "../Common/Utility.h"
#include "../DXGI/SwapChainDXGI.h"

#include <D3DX10.h>

#include "Device10.h"
#include "Effect10.h"
#include "Texture2D10.h"

using namespace System;
using namespace System::Collections::Generic;
using namespace System::Reflection;
using namespace System::Runtime::InteropServices;

namespace SlimDX
{
	namespace Direct3D10
	{
		Direct3D10Api::Direct3D10Api()
		{
		}
		
		generic< typename T >
		T Direct3D10Api::CreateWrapper( IntPtr pointer )
		{
			Type^ target = Utilities::GetInterfaceImplementation<T>();
			return (T)Activator::CreateInstance( target, pointer );
		}
		
		IDevice^ Direct3D10Api::CreateDevice()
		{
			return nullptr;//gcnew Device10();
		}

		IEffect^ Direct3D10Api::CreateEffect(IDevice^ device, System::String^ filename, System::String^ shaderProfile, ShaderFlags shaderFlags, EffectFlags effectFlags) {
			IntPtr filenamePtr = Marshal::StringToHGlobalAnsi(filename);
			IntPtr profilePtr = Marshal::StringToHGlobalAnsi(shaderProfile);

			ID3D10Effect* effect;
			ID3D10Blob* errors;
			HRESULT hr = D3DX10CreateEffectFromFileA(
				reinterpret_cast<LPCSTR>(filenamePtr.ToPointer()),
				NULL,
				NULL,
				reinterpret_cast<LPCSTR>(profilePtr.ToPointer()),
				static_cast<UINT>(shaderFlags),
				static_cast<UINT>(effectFlags),
				static_cast<ID3D10Device*>(Utilities::ToUnknown(device)),
				NULL,
				NULL,
				&effect,
				&errors,
				NULL);
			
			Marshal::FreeHGlobal(filenamePtr);
			Marshal::FreeHGlobal(profilePtr);

			RecordResult(hr);

			return gcnew Effect(effect);
		}

		SlimDX::Result Direct3D10Api::CreateDeviceAndSwapChain( SlimDX::DXGI::IAdapter^ adapter, DriverType driverType, DeviceCreationFlags creationFlags, SlimDX::DXGI::SwapChainDescription^ swapChainDescription, [Out] IDevice^% device, [Out] SlimDX::DXGI::ISwapChain^% swapChain )
		{
			ID3D10Device* nativeDevice = 0;
			IDXGISwapChain* nativeSwapChain = 0;
			DXGI_SWAP_CHAIN_DESC nativeSwapChainDescription = Utilities::ToNative( swapChainDescription );
			
			HRESULT hr = D3D10CreateDeviceAndSwapChain(
				0,
				static_cast<D3D10_DRIVER_TYPE>( driverType ),
				0,
				static_cast<UINT>( creationFlags ),
				D3D10_SDK_VERSION,
				&nativeSwapChainDescription,
				&nativeSwapChain,
				&nativeDevice
			);
			
			if( RecordResult( hr ).IsSuccess )
			{
				device = gcnew Device( nativeDevice );
				swapChain = gcnew SlimDX::DXGI::SwapChain( nativeSwapChain );
			}
			else
			{
				device = nullptr;
				swapChain = nullptr;
			}
			
			return Result::Last;
		}
	}
}