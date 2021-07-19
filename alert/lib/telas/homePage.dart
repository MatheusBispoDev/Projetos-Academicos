import 'package:alert/widgets/botaoSelecao.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/rendering.dart';

class HomePage extends StatelessWidget {
  const HomePage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        child: SafeArea(
          child: Container(
            margin: EdgeInsets.only(top: 8),
            child: ListView(
              physics: ClampingScrollPhysics(),
              children: [
                CabecalhoTela(),
                SizedBox(height: 55),
                ListaOpceos(descricao: 'Categorias'),
                Container(
                  height: 150,
                  child: ListView(
                    scrollDirection: Axis.horizontal,
                    children: [
                      CardMenus(
                        operation: 'Costas',
                        isSelected: false,
                        context: this,
                        selectedIcon: 'assets/svg/back.png',
                        unselectedIcon: 'assets/svg/back.png',
                      ),
                      CardMenus(
                        operation: 'Mãos',
                        isSelected: false,
                        context: this,
                        selectedIcon: 'assets/svg/hand.png',
                        unselectedIcon: 'assets/svg/hand.png',
                      ),
                      CardMenus(
                        operation: 'Lombar',
                        isSelected: false,
                        context: this,
                        selectedIcon: 'assets/svg/hand.png',
                        unselectedIcon: 'assets/svg/hand.png',
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}

class CabecalhoTela extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      margin: EdgeInsets.only(left: 16, right: 16, top: 16),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: <Widget>[
          NomeConta(),
          ImagemPerfil(),
        ],
      ),
    );
  }
}

class NomeConta extends StatelessWidget {
  const NomeConta({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      child: Padding(
        padding: EdgeInsets.only(left: 16, bottom: 16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: <Widget>[Text('Good Morning'), Text('Amanda Alex')],
        ),
      ),
    );
  }
}

class ImagemPerfil extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      child: Container(
        height: 59,
        width: 59,
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(20),
          //image: DecorationImage(
          //image: AssetImage('assets/images/user_image.png'),
          //),
        ),
        child: Text('Oi - Icone Perfil'),
      ),
    );
  }
}

class ListaOpceos extends StatelessWidget {
  final String descricao;

  const ListaOpceos({required this.descricao, Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: EdgeInsets.only(left: 16, bottom: 13, top: 29, right: 10),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: <Widget>[
          Text(descricao),
          Row(
            children: [
              BotaozinhoSelecao(1),
              BotaozinhoSelecao(2),
              BotaozinhoSelecao(2),
            ],
          )
        ],
      ),
    );
  }
}

class CardMenus extends StatefulWidget {
  final String operation;
  final String selectedIcon;
  final String unselectedIcon;
  final bool isSelected;
  final HomePage context;

  CardMenus(
      {required this.operation,
      required this.selectedIcon,
      required this.unselectedIcon,
      required this.isSelected,
      required this.context});

  @override
  _CardMenusState createState() => _CardMenusState();
}

class _CardMenusState extends State<CardMenus> {
  @override
  Widget build(BuildContext context) {
    return Container(
      margin: EdgeInsets.only(right: 16),
      width: 123,
      height: 123,
      decoration: BoxDecoration(
          boxShadow: [
            BoxShadow(
              color: Colors.pink,
              blurRadius: 10,
              spreadRadius: 5,
              offset: Offset(8.0, 8.0),
            )
          ],
          borderRadius: BorderRadius.circular(15),
          color: widget.isSelected ? Colors.white : Colors.pink),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.center,
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
          //SvgPicture.asset(
             // widget.isSelected ? widget.selectedIcon : widget.unselectedIcon, height: 60,),
          Image.asset(widget.isSelected ? widget.selectedIcon : widget.unselectedIcon, height: 60,),
          SizedBox(
            height: 9,
          ),
          Text(
            widget.operation,
            textAlign: TextAlign.center,
          )
        ],
      ),
    );
  }
}
