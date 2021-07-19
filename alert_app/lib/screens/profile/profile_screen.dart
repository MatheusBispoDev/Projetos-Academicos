import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/screens/profile/profile_menu.dart';
import 'package:alertapp/screens/profile/profile_pic.dart';
import 'package:flutter/material.dart';

class ProfileScreen extends StatelessWidget {
  static String routeName = "/profile";
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        padding: EdgeInsets.symmetric(vertical: 20),
        child: Column(
          children: [
            SizedBox(height: getProportionateScreenHeight(100)),
            ProfilePic(),
            SizedBox(height: getProportionateScreenHeight(30)),
            ProfileMenu(
              text: "Minha Conta",
              icon: "assets/images/icons/user.png",
              press: () => {},
            ),
            ProfileMenu(
              text: "Cronômetro",
              icon: "assets/images/icons/clock.png",
              press: () {},
            ),
            ProfileMenu(
              text: "Identificar LER",
              icon: "assets/images/icons/lupa.png",
              press: () {},
            ),
            ProfileMenu(
              text: "Sobre",
              icon: "assets/images/icons/info.png",
              press: () {},
            ),
            ProfileMenu(
              text: "Sair",
              icon: "assets/images/icons/logout.png",
              press: () {},
            ),
          ],
        ),
      ),
    );
  }
}
