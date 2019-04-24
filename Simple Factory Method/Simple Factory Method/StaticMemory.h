#pragma once
#include"IMemoryManager.h"

namespace static_memory {
	const int POOL_SIZE = 100000;

	class StaticMemory : public memory_manager::IMemoryManager {
	public:
		void* allocate(size_t size);
		void free(void* pToDelete);
	private:
	};
}