#include "MemoryManagerFactory.h"

memory_manager::IMemoryManager* memory_manager_factory::MemoryManagerFactory::GetMemoryManager(memory_manager_factory::MemoryTypes type) {
	switch (type)
	{
	case memory_manager_factory::Static: {
		return new static_memory::StaticMemory();
	}
	case memory_manager_factory::Dynamic:
		return new dynamic_memory::DynamicMemory();
	default:
		break;
	}

	return nullptr;
}

memory_manager_factory::MemoryManagerFactory::~MemoryManagerFactory() {
}