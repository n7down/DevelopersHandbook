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

TEST(RunnerTechiqueTest, rearrange_nodes_using_runner_technique)
{
	LinkedList<int> d0;
	d0.append(10).append(11).append(12).append(13).append(20).append(21).append(22).append(23);

	LinkedList<int> e0;
	e0.append(10).append(20).append(11).append(21).append(12).append(22).append(13).append(23);

	LinkedList<int> a0 = RunnerTechnique::run(d0);
	EXPECT_TRUE(a0 == e0) << a0.print() << " and " << e0.print() << " should be equal";
}

