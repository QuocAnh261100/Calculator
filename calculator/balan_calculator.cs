using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class balan_calculator
    {
        public static int set_priority(char x)
        {
            if (x.Equals('+'))
                return 1;
            else if (x.Equals('-'))
                return 1;
            else if (x.Equals('*'))
                return 2;
            else if (x.Equals('/'))
                return 2;
            else if (x.Equals('^'))
                return 3;
            else
                return 100;
        }
        public Queue<string> tokenizer(string a)
        {
            bool flag = false;
            int i;
            Queue<string> S = new Queue<string>();
            Stack<char> op = new Stack<char>();
            int priority_after = 0;
            int priority_after_1 = 0;
            int priority_before;
            int n = a.Length;
            Queue<char> opcode = new Queue<char>();
            Queue<string> Number = new Queue<string>();
            i = 0;
            int R = 0;
            while (R < n)
            {

                if (a[R].Equals('+') || a[R].Equals('-') || a[R].Equals('/') || a[R].Equals('*') 
                    || a[R].Equals('(') || a[R].Equals(')') || a[R].Equals('^'))
                {
                    opcode.Enqueue(a[R]);
                    Number.Enqueue("_");

                    R = R + 1;
                }
                else
                {

                    Queue<char> temp = new Queue<char>();

                    while (!(a[R].Equals('+') || a[R].Equals('-') || a[R].Equals('/') || a[R].Equals('*')
                        || a[R].Equals('(') || a[R].Equals(')') || a[R].Equals('^')) && (R < a.Length))
                    {
                        temp.Enqueue(a[R]);
                        R = R + 1;

                        if (R == n)
                            break;
                    }
                    Number.Enqueue(string.Concat(temp).Trim());

                }
            }
            int queue_size = Number.Count;
            while (Number.Count > 0)
            {

                if (Number.Peek().Equals("_") == false)
                    S.Enqueue(Number.Dequeue());
                else
                {
                    if (flag == false)
                    {
                        if (opcode.Peek().Equals('('))
                        {
                            flag = true;
                            op.Push(opcode.Dequeue());
                        }
                        else
                        {
                            priority_before = set_priority(opcode.Peek());
                            while (priority_after >= priority_before && op.Count > 0)
                            {
                                priority_after = priority_before;
                                priority_before = set_priority(opcode.Peek());
                                S.Enqueue(Convert.ToString(op.Pop()));
                            }
                            op.Push(opcode.Dequeue());
                            priority_after = priority_before;
                        }
                    }
                    else
                    {
                        if (!opcode.Peek().Equals(')'))
                        {

                            int priority_before_1 = set_priority(opcode.Peek());
                            while (priority_after_1 >= priority_before_1 && op.Count > 0)
                            {
                                priority_after_1 = priority_before_1;
                                priority_before_1 = set_priority(opcode.Peek());
                                S.Enqueue(Convert.ToString(op.Pop()));
                            }
                            op.Push(opcode.Dequeue());
                            priority_after_1 = priority_before_1;
                        }
                        else
                        {
                            while (!(op.Peek().Equals('(')))
                            {
                                string pop_operation = Convert.ToString(op.Pop());
                                S.Enqueue(pop_operation);
                            }
                            op.Pop();
                            opcode.Dequeue();
                            flag = false;
                        }
                        priority_after_1 = 0;
                    }
                    Number.Dequeue();
                }
            }
            while (op.Count > 0)
            {
                if (!(op.Peek().Equals('(')))
                    S.Enqueue(Convert.ToString(op.Pop()));
                else
                    op.Pop();
            }
            return S;
        }
        public double calculate_sulfix(Queue<string> a)
        {
            Stack<double> st = new Stack<double>();
            double number_1;
            double number_2;
            while (a.Count > 0)
            {
                try
                {
                    if (a.Peek().Equals("+"))
                    {
                        number_1 = st.Pop();
                        number_2 = st.Pop();
                        st.Push(number_2 + number_1);
                        a.Dequeue();
                    }
                    else if (a.Peek().Equals("-"))
                    {
                        number_1 = st.Pop();
                        number_2 = st.Pop();
                        st.Push(number_2 - number_1);
                        a.Dequeue();
                    }
                    else if (a.Peek().Equals("*"))
                    {
                        number_1 = st.Pop();
                        number_2 = st.Pop();
                        st.Push(number_2 * number_1);
                        a.Dequeue();
                    }
                    else if (a.Peek().Equals("/"))
                    {
                        number_1 = st.Pop();
                        number_2 = st.Pop();
                        st.Push(number_2 / number_1);
                        a.Dequeue();
                    }
                    else if (a.Peek().Equals("^"))
                    {
                        number_1 = st.Pop();
                        number_2 = st.Pop();
                        st.Push(Math.Pow(number_2, number_1));
                        a.Dequeue();
                    }
                    else if (a.Peek().Equals(" "))
                    {
                        a.Dequeue();
                        continue;
                    }
                    else
                    {
                        string m = a.Dequeue();

                        st.Push(Convert.ToDouble(m));
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }
            return st.Pop();
        }
    }
}
