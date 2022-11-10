namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int line, int column)
        {
            this.linhas = line;
            this.colunas = column;
            pecas = new Peca[linhas, colunas];
        }
    }
}
