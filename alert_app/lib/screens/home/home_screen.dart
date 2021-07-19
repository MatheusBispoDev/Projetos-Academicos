import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/screens/home/categories.dart';
import 'package:alertapp/screens/home/ler_section.dart';
import 'package:alertapp/screens/home/stretches_section.dart';
import 'package:alertapp/widgets/icon_btn_with_counter.dart';
import 'package:alertapp/widgets/search_field.dart';
import 'package:alertapp/widgets/section_title.dart';
import 'package:flutter/material.dart';

const String title = "Sintomas";
const String appTitle = "ALERT";
const String subtitle = "Veja todos";

class HomeScreen extends StatelessWidget {
  static String routeName = '/home';

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: SingleChildScrollView(
          child: Column(
            children: [
              SizedBox(height: getProportionateScreenHeight(10)),
              SectionTitle(title: 'ALERT'),
              SizedBox(height: getProportionateScreenHeight(20)),
              //HomeHeader(),
              SizedBox(height: getProportionateScreenWidth(10)),
              SectionTitle(title: 'Categorias'),
              Categories(),
              LerSection(),
              SizedBox(height: getProportionateScreenWidth(30)),
              StretchesSection(),
              SizedBox(height: getProportionateScreenWidth(30)),
            ],
          ),
        ),
      ),
    );
  }
}

class HomeHeader extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Padding(
      padding:
          EdgeInsets.symmetric(horizontal: getProportionateScreenWidth(20)),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          SearchField(),
          IconBtnWithCounter(
              imageAsset: "assets/images/icons/clock.png",
              press: () {
                //Navigator.pushNamed(context, CartScreen.routeName),
              }),
        ],
      ),
    );
  }
}
