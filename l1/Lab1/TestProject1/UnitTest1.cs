using Lab1;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UnitTest
        {
            [TestMethod]
            public void TestMethodCountElements()
            {
                List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
                foreach (int n in sizes)
                {
                    Problem problem = new Problem(n);
                    Assert.AreEqual(n, problem.get_items().Count);
                }
            }
            [TestMethod]

            public void TestMethodAtLeastOneElement()
            {
                Problem problem = new Problem(10);
                bool is_ok = false;
                int capacity = 10;
                foreach (Item item in problem.get_items())
                {
                    if (item.get_weight() < capacity) is_ok = true;
                }
                problem.solve(capacity);

                if (is_ok)
                {
                    Assert.AreNotEqual(0, problem.get_result().items.Count);
                }
                else
                {
                    Assert.AreEqual(0, problem.get_result().items.Count);
                }

            }

            [TestMethod]
            public void TestMethodReverseOrder()
            {
                List<int> sizes = new List<int>() { 10, 20, 30, 40, 50, 200 };
                int capacity = 10;
                foreach (int n in sizes)
                {
                    Problem problem = new Problem(n);
                    Result in_order = problem.solve(capacity);
                    problem.items.Reverse();
                    Assert.AreEqual(in_order.total_value, problem.solve(capacity).total_value);
                }
            }

            [TestMethod]

            public void TestMethodInstanceCheck()
            {
                Problem problem = new Problem(4);
                List<int> values = new List<int> { 100, 1, 2, 100 };
                List<int> weights = new List<int> { 1, 5, 6, 7 };
                int capacity = 8;
                List<int> result_numbers = new List<int> { 3, 0 };
                List<int> result_weights = new List<int> { 7, 1 };
                List<int> result_values = new List<int> { 100, 100 };

                for (int i = 0; i < values.Count; i++)
                {
                    problem.items[i].set_value(values[i]);
                    problem.items[i].set_weight(weights[i]);
                    problem.items[i].set_n(i);
                }

                Result res = problem.solve(capacity);

                for (int i = 0; i < result_numbers.Count; i++)
                {
                    Assert.AreEqual(result_numbers[i], res.items[i].get_n());
                    Assert.AreEqual(result_values[i], res.items[i].get_value());
                    Assert.AreEqual(result_weights[i], res.items[i].get_weight());
                }

            }

            [TestMethod]

            public void TestMethodNoOverflow()
            {
                List<int> capacities = new List<int>() { 10, 20, 30, 40, 50 };
                foreach (int n in capacities)
                {
                    Problem problem = new Problem(100);
                    bool overflow = false;

                    if (problem.solve(n).total_weight > n)
                    {
                        overflow = true;
                    }

                    Assert.IsFalse(overflow);
                }
            }

            [TestMethod]

            public void TestMethodPositiveValue()
            {
                List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
                foreach (int n in sizes)
                {
                    Problem problem = new Problem(n);
                    bool below0 = false;

                    if (problem.solve(50).total_value < 0)
                    {
                        below0 = true;
                    }

                    Assert.IsFalse(below0);
                }
            }

            [TestMethod]

            public void TestMethodNoDuplicates()
            {
                List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
                foreach (int n in sizes)
                {
                    Problem problem = new Problem(n);
                    bool duplicated = false;

                    Result result = problem.solve(50);

                    List<int> existed = new List<int>();

                    foreach (Item e in result.items)
                    {
                        if (existed.Contains(e.get_n()))
                        {
                            duplicated = true;
                        }
                        else
                        {
                            existed.Add(e.get_n());
                        }
                    }

                    Assert.IsFalse(duplicated);
                }
            }

            [TestMethod]

            public void TestMethodTotalWeightMoreThan0()
            {
                List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
                foreach (int n in sizes)
                {
                    Problem problem = new Problem(n);
                    bool morethan0 = true;

                    if (problem.solve(n).total_weight < 0)
                    {
                        morethan0 = false;
                    }

                    Assert.IsTrue(morethan0);
                }
            }

            [TestMethod]

            public void TestMethodResultInstance()
            {
                Problem problem = new Problem(100);

                Assert.IsInstanceOfType<Result>(problem.solve(11));
            }
        }

    }
}

