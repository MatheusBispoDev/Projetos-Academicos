class Stretches {
  final String name;
  final List<String> steps;
  final String video;
  final String image;
  final bool isFavorite;

  Stretches(
      {required this.name,
      required this.steps,
      required this.video,
      this.image = 'assets/images/stretches/teste.jpg',
      this.isFavorite = false});

  String getSteps() {
    String steps = '';
    int i = 0;
    int lengthList = this.steps.length;

    while(i < lengthList){
      steps += '${this.steps[i].toString()}\n';
      i++;
    }

    return steps;
  }

  static List<Stretches> stretchesList = [
    Stretches(
      name: 'Mãos, dedos e punhos',
      steps: [
        'a) Separe e estique os dedos até sentir a tensão de um alongamento. Mantenha por 10 segundos, então relaxe.',
        'b) Dobre os dedos nas articulações e mantenha por 10 segundos. Repita uma vez.',
      ],
      video: 'exercícios para os membros superiores',
      isFavorite: true,
    ),
    Stretches(
      name: 'Punhos e antebraços',
      steps: [
        'a) Com os braços esticados, palmas das mãos voltadas para baixo, dobre os punhos e levante as pontas dos dedos. Mantenha por 10 segundos.',
        'b) Dobre os punhos na direção oposta, dedos apontando para baixo. Mantenha por 10 segundos.',
      ],
      video: 'exercícios para os membros superiores',
    ),
    Stretches(
      name: 'Punhos',
      steps: [
        'a) Entrelace os dedos a sua frente e gire as mãos e os punhos no sentido horário 10 vezes',
        'b) Repita o exercício no sentido anti-horário também por 10 vezes.',
      ],
      video: 'exercícios para os membros superiores',
    ),
    Stretches(
      name: 'Punhos e antebraços',
      steps: [
        'a) Com o braço direito esticado, vire a palma da mão para cima.',
        'b) Leve a mão esquerda sob o antebraço e segure o polegar e a parte de dentro da palma.',
        'c) Vire a mão direita para fora e para baixo até sentir um alongamento suave. Mantenha por 5-10 segundos e, então, repita com o outro braço.',
      ],
      video: 'exercícios para os membros superiores',
    ),
    Stretches(
      name: 'Punhos e antebraços',
      steps: [
        'a) Com os braços estendidos à sua frente, lentamente, vire as mãos para fora até sentir um alongamento. Mantenha por 5 a 10 segundos.',
      ],
      video: 'exercícios para os membros superiores',
      isFavorite: true,
    ),
  ];
}
