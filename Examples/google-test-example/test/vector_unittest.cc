#include <gtest/gtest.h>
#include <vector>
 
using namespace std;
 
// A new one of these is created for each test
class VectorTest : public testing::Test
{
public:
  vector<int> m_vector;
 
  virtual void SetUp()
  {
    m_vector.push_back(1);
    m_vector.push_back(2);
  }
 
  virtual void TearDown()
  {
  }
};
 
TEST_F(VectorTest, testElementZeroIsOne)
{
  EXPECT_EQ(1, m_vector[0]);
}
 
TEST_F(VectorTest, testElementOneIsTwo)
{
  EXPECT_EQ(2, m_vector[1]);
}
 
TEST_F(VectorTest, testSizeIsTwo)
{
  EXPECT_EQ((unsigned int)2, m_vector.size());
}
