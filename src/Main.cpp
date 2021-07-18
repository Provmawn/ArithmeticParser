#include "ChildNode.h"
#include "RootNode.h"
#include <iostream>

int main() {
	ChildNode five(5);
	ChildNode six(6);
	RootNode fiveplussix(five, six, RootNode::Operation::ADD);
	std::cout << "5 + 6 = " << fiveplussix.getSum();
	return 0;
}