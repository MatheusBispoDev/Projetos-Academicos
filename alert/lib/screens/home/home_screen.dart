import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/widgets/categories.dart';
import 'package:alertapp/widgets/icon_btn_with_counter.dart';
import 'package:alertapp/widgets/popular_product.dart';
import 'package:alertapp/widgets/search_field.dart';
import 'package:alertapp/widgets/special_offers.dart';
import 'package:flutter/material.dart';

class HomeScreen extends StatelessWidget {
  static String routeName = '/home';

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
        child: SingleChildScrollView(
          child: Column(
            children: [
              SizedBox(height: getProportionateScreenHeight(20)),
              HomeHeader(),
              SizedBox(height: getProportionateScreenWidth(10)),
              Categories(), //Vou pegar
              SpecialOffers(), //Vou
              SizedBox(height: getProportionateScreenWidth(30)),
              PopularProducts(), //Vou
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
            imageAsset: "assets/icons/Cart Icon.svg",
            press: () {
              //Navigator.pushNamed(context, CartScreen.routeName),
            }
          ),
          IconBtnWithCounter(
            imageAsset: "assets/icons/Bell.svg",
            numOfitem: 3,
            press: () {},
          ),
        ],
      ),
    );
  }
}



