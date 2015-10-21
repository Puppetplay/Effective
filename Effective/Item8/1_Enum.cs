using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item8
{
    class _1_Enum
    {
        public void Func1()
        {
            // 할당되지 않은 값
            Planet sphere = new Planet();
            int i = (int)sphere;

            sphere = Planet.Mars;

            // 할당하기 힘듬
            ObservationData d = new ObservationData();

        }
    }

    public enum Planet
    {
        None = 0,
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Neptune = 7,
        Uranus = 8,
        Pluto = 8
    }

    //public class ObservationData
    public struct ObservationData
    {
        Planet _whichPlanet;
        Double _magnitude;

        //private ObservationData(Planet target, Double mag)
        //{
        //    //구조체에서는 사용불가.
        //}

        ObservationData(Planet target, Double mag)
        {
            _whichPlanet = target;
            _magnitude = mag;
        }
    }
}
