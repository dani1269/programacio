

string calcularQualitativa(float notaExamen, float notaPractiques)
{
    
    if (notaExamen < 3 || notaPractiques < 3)
    {
        return "Suspens";
    }

    
    float notaGlobal = (float)(0.8 * notaExamen + 0.2 * notaPractiques);

    
    if (notaGlobal == 10)
    {
        return "Matrícula d'Honor";
    }
    else if (notaGlobal >= 9)
    {
        return "Excel·lent";
    }
    else if (notaGlobal >= 7)
    {
        return "Notable";
    }
    else if (notaGlobal >= 5)
    {
        return "Aprovat";
    }
    else
    {
        return "Suspens";
    }
}


string processarNotes(float notaExamen, float notaPractiques)
{
   
    return calcularQualitativa(notaExamen, notaPractiques);
}

int main()
{
    string resultat = processarNotes(notaExamen, notaPractiques);

    
    return 0; 
}
