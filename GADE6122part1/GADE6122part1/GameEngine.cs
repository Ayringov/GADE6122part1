using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122part1
{
    class GameEngine
    {

        Map map;
        public Hero hero;

        public GameEngine()
        {
            map = new Map(10, 25, 10, 25, 5);
            hero = map.Hero;
        }
        public string View
        {
            get { return map.ToString(); }
        }


        public bool MovePlayer(Movement desiredMove)
        {
            Movement allowedMove = map.Hero.ReturnMove(desiredMove);
            map.Hero.Move(allowedMove);
            map.Update();

            if (allowedMove == Movement.No_Movement)
            {
                return false;
            }

            return true;
        }
    }
}
