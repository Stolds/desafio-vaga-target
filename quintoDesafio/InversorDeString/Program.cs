
string texto = "A revolução não será televisionada";

string textoInvertido = InverterTexto(texto);

string InverterTexto(string texto)
{
    char[] caracteres = texto.ToCharArray();
    int tamanho = caracteres.Length;

    for (int i = 0; i < tamanho / 2; i++)
    {
        char temp = caracteres[i];
        caracteres[i] = caracteres[tamanho - 1 - i];
        caracteres[tamanho - 1 - i] = temp;
    }

    return new string(caracteres);
}

Console.WriteLine(textoInvertido);
