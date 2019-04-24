#pragma once
#include"IMemoryManager.h"

namespace dynamic_memory {
	class DynamicMemory : public memory_manager::IMemoryManager {
	public:
		void* allocate(size_t size);
		void free(void* pToDelete);
	private:

	};
}