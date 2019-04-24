#include<iostream>
#include"MemoryManagerFactory.h"

int main() {

	memory_manager::IMemoryManager* pMemManager = memory_manager_factory::MemoryManagerFactory::GetMemoryManager(memory_manager_factory::Static);

	if (pMemManager != nullptr)
		std::cout << "All is good";
	else
		std::cout << "Something is bad";

	void *p = pMemManager->allocate(10);
	pMemManager->free(p);

	return 0;
}