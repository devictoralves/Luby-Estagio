class Buscador
{
    private string[] _vetor;

    public Buscador(string[] vetor)
    {
        _vetor = vetor;
    }

    public string[] Buscar(string valorBusca)
    {
        return _vetor.Where(x => x.Contains(valorBusca)).ToArray();
    }
}