import 'package:alertapp/theme/constants.dart';
import 'package:flutter/material.dart';
import 'model_custom_bottom_nav.dart';

class CustomNavBottom extends StatefulWidget {
  static String routeName = "/navbutton";

  @override
  _CustomNavBottomState createState() => _CustomNavBottomState();
}

class _CustomNavBottomState extends State<CustomNavBottom> {
  static const List<Widget> _widgetOptions = <Widget>[
    Center(child: Text('Home1')),
    Center(child: Text("Sintomas")),
    Center(child: Text("Relatórios")),
    Center(child: Text("Profile")),
  ];

  MenuState selectedMenu = MenuState.home;
  int _selectedIndex = 0;

  void onItemTapped({required int index, required MenuState selectedMenu}) {
    setState(() {
      _selectedIndex = index;
      this.selectedMenu = selectedMenu;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: _widgetOptions.elementAt(_selectedIndex),
      bottomSheet: Container(
        padding: EdgeInsets.symmetric(vertical: 14),
        decoration: BoxDecoration(
          color: Colors.white,
          boxShadow: [
            BoxShadow(
              offset: Offset(0, -15),
              blurRadius: 20,
              color: Color(0xFFDADADA).withOpacity(0.15),
            ),
          ],
          borderRadius: BorderRadius.only(
            topLeft: Radius.circular(40),
            topRight: Radius.circular(40),
          ),
        ),
        child: SafeArea(
          top: false,
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceAround,
            children: [
              IconButton(
                icon: Image.asset(
                  homeImageAssets,
                  color: MenuState.home == selectedMenu
                      ? kPrimaryColor
                      : inActiveIconColor,
                ),
                onPressed: () {
                  onItemTapped(index: 0, selectedMenu: MenuState.home);
                },
              ),
              IconButton(
                icon: Image.asset(painImageAssets,
                  color: MenuState.pain == selectedMenu
                      ? kPrimaryColor
                      : inActiveIconColor,),
                onPressed: () {
                  onItemTapped(index: 1, selectedMenu: MenuState.pain);
                },
              ),
              IconButton(
                icon: Image.asset(diaryImageAssets,
                  color: MenuState.diary == selectedMenu
                      ? kPrimaryColor
                      : inActiveIconColor,),
                onPressed: () {
                  onItemTapped(index: 2, selectedMenu: MenuState.diary);
                },
              ),
              IconButton(
                icon: Image.asset(
                  profileImageAssets,
                  color: MenuState.profile == selectedMenu
                      ? kPrimaryColor
                      : inActiveIconColor,
                ),
                onPressed: () {
                  onItemTapped(index: 3, selectedMenu: MenuState.profile);
                },
              ),
            ],
          ),
        ),
      ),
    );
  }
}