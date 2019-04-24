#pragma once
#include"IMemoryManager.h"
#include"DynamicMemory.h"
#include"StaticMemory.h"

namespace memory_manager_factory {
	enum MemoryTypes {
		Static = 10,
		Dynamic = 20
	};

	class MemoryManagerFactory {
	public:
		static memory_manager::IMemoryManager* GetMemoryManager(MemoryTypes type);
		virtual ~MemoryManagerFactory() = 0;
	};
}