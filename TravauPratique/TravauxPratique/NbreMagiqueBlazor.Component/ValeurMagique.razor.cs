namespace NbreMagiqueBlazor.Component
{
    public partial class ValeurMagique
    {
        Random Random = new Random();

        public bool isFound(string valeurString)
        {
            var valeur = int.Parse(valeurString);
            int nbreAlea = Random.Next(1, 6);

            if (nbreAlea == valeur)
            {
                return true;
            }
            return false;   
        }
    }
}