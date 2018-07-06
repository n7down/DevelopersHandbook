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
	LinkedList<std::string> d0;
	d0.append("a1").append("a2").append("a3").append("a4").append("b1").append("b2").append("b3").append("b4");

	LinkedList<std::string> e0;
	e0.append("a1").append("b1").append("a2").append("b2").append("a3").append("b3").append("a4").append("b4");

	//RunnerTechnique::run(d0);
	//EXPECT_TRUE(d0 == e0) << d0.print() << " and " << e0.print() << " should be equal";
	EXPECT_TRUE(false);
}

