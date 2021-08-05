namespace Adapter_Pattern
{
    /// <summary>
    /// Implementar a interface do tipo que vais adaptar.
    /// Esta é a interface que o cliente quer ver
    /// </summary>
    public class TurkeyAdapter : IDuck
    {
        /// <summary>
        /// Obter a refenrencia to objeto que queremos adaptar
        /// </summary>
        private ITurkey turkey;
        
        // Passar para o construtor
        public TurkeyAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }
        
        /// <summary>
        /// Implementamos os metodos na interface
        /// Transição entree classes é simples
        /// </summary>
        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }
    }
}