import 'package:flutter/material.dart';

class BotaozinhoSelecao extends StatelessWidget {
  final int isSelected;

  BotaozinhoSelecao(this.isSelected);

  @override
  Widget build(BuildContext context) {
    return Container(
      alignment: Alignment.centerLeft,
      height: 9,
      width: 9,
      margin: EdgeInsets.only(right: 6),
      decoration: BoxDecoration(
          shape: BoxShape.circle,
          color: isSelected == 1 ? Colors.pink : Colors.black),
    );
  }
}
