#include "linkedlist.h"
#include "runnertechnique.h"

#include <gtest/gtest.h>
#include <iostream>
#include <string>

class RunnerTechniqueTest : public ::testing::Test
{
protected:
	virtual void SetUp()
	{}

	virtual void TearDown()
	{}

public:
};

TEST(RunnerTechiqueTest, rearrange_nodes_using_runner_techique)
{
	LinkedList<int> d0;
	d0.append(1).append(1).append(1).append(1).append(2).append(2).append(2).append(2);

	LinkedList<int> e0;
	e0.append(1).append(2).append(1).append(2).append(1).append(2).append(1).append(2);

	// FIXME:
	// LinkedList<int> a0 = RunnerTechnique::run(d0);
	// EXPECT_TRUE(a0 == e0) << a0.print() << " and " << e0.print() << " should be equal";
}

