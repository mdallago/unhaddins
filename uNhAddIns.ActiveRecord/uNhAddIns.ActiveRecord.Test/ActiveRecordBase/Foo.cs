using Castle.ActiveRecord;

namespace uNhAddIns.ActiveRecord.Test.ActiveRecordBase
{
    [Castle.ActiveRecord.ActiveRecord]
    public class Foo : ActiveRecordBase<Foo>
    {
        private int id;
        private string name;

        public Foo() {
        }

        public Foo(int id, string name) {
            this.id = id;
            this.name = name;
        }

        [PrimaryKey(PrimaryKeyType.Assigned)]
        public int Id {
            get { return id; }
            set { id = value; }
        }

        [Property]
        public string Name {
            get { return name; }
            set { name = value; }
        }
    }
}