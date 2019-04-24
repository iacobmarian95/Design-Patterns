#pragma once

namespace memory_manager {
	class IMemoryManager {
	public:
		virtual void* allocate(size_t size) = 0;
		virtual void free(void * pToDelete) = 0;
	};
}