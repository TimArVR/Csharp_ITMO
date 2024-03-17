using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();

    }

    class ArithProgression : ISeries
    {
        int _startValue;
        int _step;
        int _currentValue;
        public int GetNext()
        {
            _currentValue += _step;
            return _currentValue;
        }

        public void Reset()
        {
            _currentValue = _startValue;
        }

        public void SetStart(int x)
        {
            _startValue = x;
            _currentValue = _startValue;
        }
        public void SetStep(int s)
        {
            _step = s;
        }
    }

    class GeomProgression : ISeries
    {
        int _startValue;
        int _step;
        int _currentValue;
        public int GetNext()
        {
            _currentValue *= _step;
            return _currentValue;
        }

        public void Reset()
        {
            _currentValue = _startValue;
        }

        public void SetStart(int x)
        {
            _startValue = x;
            _currentValue = _startValue;
        }
        public void SetStep(int s)
        {
            _step = s;
        }
    }

}
