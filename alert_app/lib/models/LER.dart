class LER {
  final int id;
  final String name;
  final String description;
  final String symptoms;
  final String treatments;
  final String prevention;
  final String image;

  LER({
    required this.id,
    required this.name,
    required this.description,
    required this.symptoms,
    required this.treatments,
    required this.prevention,
    this.image = 'assets/images/iconsCategories/hand.png',
  });

  static List<LER> listLers = [
    LER(
      id: 1,
      name: 'Síndrome do Túnel do Carpo',
      description:
          'Essa doença é uma forma bastante comum de LER, provocada pela compressão do nervo Mediano, que vem do braço e passa pelo punho, numa região chamada túnel do carpo. Esse nervo é o responsável pela movimentação do dedo polegar, além de promover a sensação nos dedos polegar, indicador e médio na parte da palma das mãos. Devido ao uso excessivo dos dedos e punhos, começa a haver uma inflamação e inchaço das estruturas que passam pelo túnel do carpo, resultando na compressão do nervo mediano. Como resultado, esse nervo passa a ficar mais "fraco", provocando a sensação de formigamento e amortecimento dos dedos das mãos, principalmente dos dedos polegar, indicador e médio. Às vezes, pode dar até a sensação de "choque" sentida nos dedos e indo em direção ao braço. Em geral, os sintomas pioram com o decorrer do dia, principalmente após um dia de trabalho. Alguns pacientes acordam no meio da noite com as mãos amortecidas. Essa doença é comum em mulheres de 30 a 50 anos, e acomete 3 vezes mais o sexo feminino do que o masculino. Normalmente, os sintomas estão presentes nas duas mãos, mas são notados primeiramente na mão dominante.',
      symptoms:
          'Para se fazer o diagnóstico da doença é preciso colher os dados de dor nas mãos, a perda de sensibilidade nos dedos, ou formigamento ou mesmo adormecimento dos mesmos. Também é comum o paciente se queixar que não consegue segurar bem as coisas, principalmente fazer o movimento de pinçar. A relação com a profissão tem importância fundamental no diagnóstico. Ao exame físico, um exame de grande importância é a manobra de Phalen, em que se pede para o paciente colocar as mãos em flexão, ou seja, com os dedos voltados para baixo, e unir dorso contra dorso das mãos, durante um minuto. Os cotovelos devem ficar num ângulo de 90 graus e na mesma altura dos punhos. A presença de dor ou sintomas de formigamento ou adormecimento aponta fortemente para o diagnóstico de Síndrome do túnel do carpo. Outro teste é o chamado teste de Tinnel que consiste da compressão do nervo mediano no trajeto dele pelo túnel do carpo. A presença de dor indica a presença da síndrome do túnel do carpo. Caso seja necessário, poderá ser feito um teste para medir a condução do nervo mediano, para ver se está normal ou não. Os exames de raio-X das mãos são importantes para afastar as outras causas de dor nas mãos, como artrites, tumores ou fraturas ósseas.',
      treatments:
          'O tratamento se baseia no uso de antinflamatórios, como o ibuprofeno, para aliviar a dor bem como a inflamação das estruturas envolvidas. Também o uso de munhequeiras ajuda a manter a articulação dos punhos fixa, aliviando assim a dor. O repouso é uma das melhores formas de tratamento e muitas vezes o paciente deve ficar alguns dias sem trabalhar as articulações para haver a diminuição completa da inflamação. Também pode ser administrada a vitamina B6 para melhorar as condições do nervo. Em casos mais severos, poderão ser utilizados corticóides injetados diretamente nas articulações afetadas. Nos casos em que há grande comprometimento do nervo mediano está indicada a cirurgia para a descompressão do mesmo. Essa cirurgia leva a uma melhora dos sintomas em 95% dos casos.',
      prevention:
          'A medida mais importante é evitar usar as articulações durante muito tempo. Dê umas paradas no serviço para relaxar a musculatura das mãos e dedos. Outro fator importante é a posição em que você está trabalhando. Para aqueles que usam computadores ou máquinas de escrever, é muito importante a posição em que você está sentado. Os pés devem ficar paralelos ao chão, as pernas devem ficar flexionadas no joelho, sendo que a coxa forme um ângulo de 90 graus com as costas. A cadeira deve ser bem confortável e as costas devem estar apoiadas no encosto. Os braços devem ficar na mesma altura do teclado, sendo que as mãos ficam também no mesmo nível, não forçando assim os punhos. Coloque a tela do computador de modo que você fique a uma distância de 40 a 60 centímetros dela e sua visão direta forme um ângulo de 15 a 30 graus com a mesma.',
    ),
    LER(
      id: 2,
      name: 'Tendinites dos Extensores dos Dedos',
      description: 'Tendões são estruturas que se parecem com cordões extremamente fortes, responsáveis pela fixação dos músculos nos ossos. Toda vez que o músculo se contrai, os tendões se esticam, dando-se assim o movimento desejado. O termo tendinite significa uma inflamação dessas estruturas, em geral causada por excessivo uso daquela articulação envolvida. A tendinite pode ocorrer em qualquer articulação, mas é mais comum nos punhos, nos joelhos, ombros e cotovelos. Devido à inflamação, a pessoa irá apresentar dor quando movimentar as articulações em questão. No caso das mãos, possuimos um grupo de músculos que estendem os dedos e as mãos, e os respectivos tendões passam pela parte dorsal das mãos. Da mesma forma que para a síndrome do túnel do carpo, o uso excessivo e repetitivo de certa articulação irá provocar o inchaço das estruturas presentes nas costas das mãos, provocando dor ao movimento dos dedos e punhos.',
      symptoms: 'Pode ser feito através da queixa do paciente que revela dor na parte dorsal da mão, principalmente após o uso excessivo daquelas articulações. O paciente pode se queixar de fraqueza nas mãos bem como sensação de queimação em vez de dor.',
      treatments: 'O tratamento indicado é o uso de antinflamatórios e repouso da articulação envolvida.',
      prevention: 'É preciso tomar cuidado com a posição em que se está sentado, observar a posição dos braços e mãos, principalmente para aqueles que trabalham com computadores e máquinas de escrever. Os punhos devem sempre ficar numa posição confortável, evitando que eles fiquem desalinhados com os braços e o teclado. Da mesma forma, pare o seu trabalho de tempos em tempos para relaxar a musculatura e os tendões.',
    ),
    LER(
      id: 3,
      name: 'Tenossinovite dos Flexores dos Dedos',
      description:
          'Os tendões flexores dos dedos estão presentes na parte da palma das mãos. Esses tendões estão recobertos por uma bainha chamada sinovial, que faz com que a contração do músculo fique mais "macia". Quando ocorre a inflamação dessa bainha sinovial, usa-se o termo tenossinovite, no caso dos tendões que fazem a flexão dos dedos. Devido à inflamação da bainha, quando houver contração do músculo para movimentar os dedos, aparecerá o sintoma de dor local, e o movimento das mãos não será bem realizado.',
      symptoms: 'O paciente irá se queixar dor e inflamação na parte interna da mão, principalmente quando fizer o movimento de flexão dos dedos (quando a pessoa fecha as mãos, por exemplo)',
      treatments: 'Da mesma forma, usa-se antinflamatórios para aliviar a dor e inflamação, bem como é indicado o repouso das articulações envolvidas.',
      prevention: '',
    ),
    LER(
      id: 4,
      name: 'Tenossinovite Estenosante (Dedo em Gatilho)',
      description: 'Essa doença envolve os tendões flexores dos dedos das mãos, que passam por túneis dentro dos dedos. Se houver a formação de um nódulo sobre o tendão ou ocorrer um inchaço na bainha que o cobre, ele então se tornará mais largo, ficando comprimido nos túneis por onde ele passa. Conforme a pessoa mexe os dedos, ela irá sentir um estalo ou escutar um barulho na articulação envolvida, principalmente no meio dos dedos.',
      symptoms: 'Pode ser feito através dos sintomas apresentados, bem como a referência de que a pessoa trabalha em serviços que requerem o uso da palma das mãos e o movimento de fechar os dedos, como carimbar e grampear, em movimentos repetitivos e por longos períodos.',
      treatments: 'O tratamento mais indicado para este problema é o uso de antinflamatórios e repouso das articulações.',
      prevention: 'Evitar o uso repetitivo das articulações, se possível usar um grampeador elétrico ou que ele seja acolchoado para evitar que a palma das mãos se force. A mesma coisa é válida para os carimbos. Também podem ser usadas luvas com gel para que amorteçam a batida contra a palma das mãos.',
    ),
    LER(
      id: 5,
      name: 'Epicondilite Lateral',
      description: 'Essa doença é conhecida como tennis elbow (cotovelo de tênis) e é causada pela inflamação das pequenas protuberâncias dos ossos do cotovelos, os chamados epicôndilos. Neste caso, os ossos envolvidos são os epicôndilos laterais, ou seja, da parte de fora do braço. Apesar do nome, poucos tenistas apresentam essa doença, sendo mais comum em pessoas que trabalham levantando peso, donas de casa, pessoas que fazem trabalhos manuais e que trabalham em escritórios. Alguns músculos que promovem a retificação do punho e dos dedos são presos pelos tendões no epicôndilo lateral do cotovelo. Quando houver um uso excessivo dessas estruturas, começará a se desenvolver uma inflamação das mesmas, iniciando os sintomas de dor.',
      symptoms: 'O paciente pode se queixar de dor aguda quando roda o antebraço. Em geral, a pessoa vai notando que a dor vai aumentando gradativamente conforme o uso das articulações, como ao abrir latas, ou ao abrir as fechaduras das portas ou mesmo quando vai parafusar alguma coisa. As outras doenças que causam inflamação e inchaço das juntas, como artrite, etc...devem ser afastadas.',
      treatments: 'Em geral é feito com o repouso da articulação em questão e com o uso de antinflamatórios. São úteis também os exercícios de alongamento do antebraço e músculos das mãos. Poderá ser usado um suporte para o antebraço, para reduzir a pressão na área afetada. Em casos mais graves, podem ser injetados corticóides no local afetado. Caso não haja melhora, poderá ser indicada cirurgia para alívio dos sintomas.',
      prevention: '',
    ),
  ];
}
