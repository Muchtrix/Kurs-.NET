using System.Collections;

namespace Zadanie_3._1._2 {
    public class Set : ArrayList {
        public override int Add(object value) {
            if(!base.Contains(value))
                return base.Add(value);
            return -1;
        }
    }
}
