namespace Projetolegal;

public partial class MainPage : ContentPage
{
      string[] frases = new string[9];
	  string? fraseGerada=null;

	  Random random=new Random();
 	public MainPage()
	{
		InitializeComponent();

	frases[0]="Acredite em você mesmo e tudo será possível.";
    frases[1]="O sucesso é a soma de pequenos esforços repetidos dia após dia.";
    frases[2]="A persistência realiza o impossível.";
    frases[3]="O otimismo é a fé em ação. Nada se pode realizar sem esperança e confiança.";
    frases[4]="Cada sonho que você deixa para trás é um pedaço do seu futuro que deixa de existir.";
    frases[5]="A força não vem da capacidade física, e sim da vontade indomável.";
	frases[6]="Quanto maior a dificuldade, maior será a glória.";
	frases[7]="Não espere por circunstâncias ideais, tome decisões e torne-as ideais.";
	frases[8]="O caminho para o sucesso sempre está em construção.";
	
	}
       private void BotaoGerarFoiClicado(object sender, EventArgs args)
  {
    int indice = random.Next(0, 9);
    fraseGerada = frases[indice];
    labelMsg.Text = fraseGerada;
}
}

