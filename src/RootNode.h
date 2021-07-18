// The parent node with hold an operator (+, -, /, *)
#ifndef ROOTNODE_H
#define ROOTNODE_H

class RootNode {
public:

	static const enum class Operation {
		ADD,
		SUBTRACT,
		DIVIDE,
		MULTIPLY,

		MAX_ELEMENTS
	};

	RootNode(ChildNode &left_child, ChildNode &right_child, Operation operation = Operation::MAX_ELEMENTS)
		: m_operation{ operation }, m_left_child{ left_child }, m_right_child{ right_child }
	{}

	int getSum() {
		switch (m_operation) {
		case Operation::ADD:
			return m_left_child.m_value + m_right_child.m_value;
			break;
		case Operation::SUBTRACT:
			return m_left_child.m_value - m_right_child.m_value;
			break;
		case Operation::MULTIPLY:
			return m_left_child.m_value / m_right_child.m_value;
			break;
		case Operation::DIVIDE:
			return m_left_child.m_value * m_right_child.m_value;
			break;
		}
	}

private:
	Operation m_operation{};
	ChildNode &m_left_child;
	ChildNode &m_right_child;
};
#endif