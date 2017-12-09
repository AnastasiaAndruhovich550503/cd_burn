using IMAPI2;

namespace CDBurn
{
    class BurnWriteActionPublisher
    {
        public delegate void WriteActionHandler(FormatDataWriteAction a);
        public event WriteActionHandler WriteActionChanged;

        public FormatDataWriteAction WriteAction
        {
            get => _writeAction;
            set
            {
                if (_writeAction.Equals(value)) return;
                _writeAction = value;
                WriteActionChanged?.Invoke(_writeAction);
            }
        }

        private FormatDataWriteAction _writeAction;
    }
}
