using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item19
{
    class _4_CollectionBase
    {
        public void Func1()
        {
            IntList l = new IntList();
            IList il = l as IList;
            try
            {
                il.Insert(0, 3);
                il.Insert(0, "This is bad");
            }
            catch
            {

            }
            int count = il.Count;

            IntList2 l2 = new IntList2();
            IList il2 = l2 as IList;
            try
            {
                il2.Insert(0, 3);
                il2.Insert(0, "This is bad");
            }
            catch
            {

            }
            count = il2.Count;
        }
        
    }

    public class IntList : CollectionBase
    {
        protected override void OnInsert(int index, object value)
        {
            try
            {
                int newValue = Convert.ToInt32(value);
                Console.WriteLine("Inserting {0} at position {1}", index.ToString(), value.ToString());

                Console.WriteLine("List Contains {0} items", this.List.Count.ToString());
            }
            catch(FormatException e)
            {
                throw new ArgumentException("Argument type not a integer", "value", e);
            }
        }

        protected override void OnInsertComplete(int index, object value)
        {
            Console.WriteLine("Inserted {0} at position {1}", index.ToString(), value.ToString());
            Console.WriteLine("List Contains {0} items", this.List.ToString());
        }
    }

    public class IntList2 : Collection<int>
    {
        protected override void InsertItem(int index, int item)
        {
            int count = Items.Count();
            base.InsertItem(index, item);
            count = Items.Count();
        }
    }
}
