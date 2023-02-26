public class DeterminandoSexo {
    public static void main(String[] args) {
      /*
        Os gametas masculinos ou células espermáticas em humanos e outros mamíferos são heterogaméticos e contêm um dos dois tipos de cromossomos sexuais. Eles são X ou Y. Os gametas femininos ou ovos, no entanto, contêm apenas o cromossomo sexual X e são homogaméticos.
        A célula de esperma determina o sexo de um indivíduo neste caso. Se um espermatozoide contendo um cromossomo X fertilizar um óvulo, o zigoto resultante será XX ou feminino. Se o espermatozoide contiver um cromossomo Y, o zigoto resultante será XY ou masculino.
        Determine se o sexo da prole será masculino ou feminino com base no cromossomo X ou Y presente no esperma do homem.
        Se o esperma contiver o cromossomo X, retorne "Parabéns! Você vai ter uma filha."; Se o esperma contiver o cromossomo Y, retorne "Parabéns! Você vai ter um filho.";
      */

        String x = "";
        String y = "";

        //x -> xx -> feminino
        //y -> xy -> masculino

        String result = chromosomeCheck2("XY");
        System.out.println(result);
    }

    public static String chromosomeCheck(String sperm) {
        return "Congratulations! You're going to have a " + (sperm.contains("Y") ? "son." : "daughter.");
    }

    public static String chromosomeCheck2(String sperm) {
        if (sperm.equals("XY")) {
            return "Congratulations! You're going to have a son.";
        } else if (sperm.equals("XX")) {
            return "Congratulations! You're going to have a daughter.";
        } else {
            return "";
        }

    }
}

