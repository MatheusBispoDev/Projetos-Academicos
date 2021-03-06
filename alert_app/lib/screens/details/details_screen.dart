import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/models/Stretche.dart';
import 'package:alertapp/screens/details/components/streatche_images.dart';
import 'package:alertapp/screens/details/components/stretche_description.dart';
import 'package:alertapp/widgets/default_button.dart';
import 'package:flutter/material.dart';
import 'package:fluttertoast/fluttertoast.dart';

import 'components/custom_app_bar.dart';
import 'components/top_rounded_container.dart';

class DetailsScreen extends StatelessWidget {
  static const String routeName = "/details";

  final Stretches stretche;

  const DetailsScreen({
    Key key = const Key('details'),
    required this.stretche,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: CustomAppBar(stretche.isFavorite),
      backgroundColor: Color(0xFFF5F6F9),
      body: ListView(
        children: [
          StretcheImages(stretche: stretche),
          TopRoundedContainer(
            color: Colors.white,
            child: Column(
              children: [
                StretcheDescription(
                  stretche: stretche,
                  pressOnSeeMore: () {},
                ),
                TopRoundedContainer(
                  color: Colors.white,
                  child: Padding(
                    padding: EdgeInsets.only(
                      left: SizeConfig.screenWidth * 0.15,
                      right: SizeConfig.screenWidth * 0.15,
                      bottom: getProportionateScreenWidth(70),
                      top: getProportionateScreenWidth(15),
                    ),
                    child: DefaultButton(
                      text: "Adicionar Alongamento",
                      press: () {
                        _showToast();
                      },
                    ),
                  ),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}

_showToast() {
   Widget toast = Fluttertoast.showToast(
      msg: "Funcionalidade ainda n??o implementada",
      toastLength: Toast.LENGTH_SHORT,
      gravity: ToastGravity.CENTER,
  ) as Widget;

   return toast;
}