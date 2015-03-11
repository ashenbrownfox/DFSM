using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    public class StateEventArgs : EventArgs
    {
        public StateEventArgs(int id)
        {
            m_id = id;
        }
        private int m_id;
        public int Id
        {
            get { return m_id; }
        }
    }
    public class State
    {
        private String m_state = null;
        public State(string sState)
        {
            m_state = sState;
        }
        public virtual void ChangeState(object sender,EventArgs eventArgs)
        { 
            
        }
        public override string ToString()
        {
            return m_state;
        }
    }
}
