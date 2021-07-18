#ifndef CHILDNODE_H
#define CHILDNODE_H

// forward declaration
class RootNode;

class ChildNode {
public:
	ChildNode(int value = 0, RootNode *parent = nullptr)
		: m_root{ parent }, m_value{ value }
	{}

	friend class RootNode;

private:
	int m_value{};
	RootNode *m_root{};
};
#endif