import 'package:flutter/material.dart';
import 'package:alert/telas/contasPage.dart';
import 'package:alert/telas/doencasPage.dart';
import 'package:alert/telas/homePage.dart';
import 'package:alert/telas/sintomasPage.dart';

class NavBottom extends StatefulWidget {
  const NavBottom({Key? key}) : super(key: key);

  @override
  State<NavBottom> createState() => _NavBottomState();
}

class _NavBottomState extends State<NavBottom> {
  int _selectedIndex = 0;
  static const List<Widget> _widgetOptions = <Widget>[
    HomePage(),
    SintomasPage(),
    DoencasPage(),
    ContaPage()
  ];

  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: _widgetOptions.elementAt(_selectedIndex),
      bottomNavigationBar: BottomNavigationBar(
        items: const <BottomNavigationBarItem>[
          BottomNavigationBarItem(
            icon: Icon(Icons.home),
            label: 'Home',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.air_outlined),
            label: 'Sintomas',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.animation),
            label: 'Doenças',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.person),
            label: 'Conta',
          ),
        ],
        type: BottomNavigationBarType.fixed,
        currentIndex: _selectedIndex,
        selectedItemColor: Colors.pink,
        unselectedItemColor: Colors.black,
        backgroundColor: Colors.white,
        showSelectedLabels: true,
        showUnselectedLabels: false,
        onTap: _onItemTapped,
      ),
    );
  }
}
