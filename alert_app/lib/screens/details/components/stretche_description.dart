import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/models/Stretche.dart';
import 'package:alertapp/theme/constants.dart';
import 'package:flutter/material.dart';

class StretcheDescription extends StatelessWidget {
  const StretcheDescription({
    Key? key,
    required this.stretche,
    required this.pressOnSeeMore,
  }) : super(key: key);

  final Stretches stretche;
  final GestureTapCallback pressOnSeeMore;

  @override
  Widget build(BuildContext context) {
    debugPrint('teste: ${stretche.getSteps()}');
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Padding(
          padding:
              EdgeInsets.symmetric(horizontal: getProportionateScreenWidth(20)),
          child: Text(
            'Alongamento:',
            style: Theme.of(context).textTheme.headline6,
          ),
        ),
        Padding(
          padding:
              EdgeInsets.symmetric(horizontal: getProportionateScreenWidth(20)),
          child: Text(
            stretche.name,
            style: Theme.of(context).textTheme.headline6,
          ),
        ),
        SizedBox(height: getProportionateScreenHeight(20)),
        Padding(
          padding: EdgeInsets.only(
            left: getProportionateScreenWidth(20),
            right: getProportionateScreenWidth(64),
          ),
          child: Text(
            stretche.getSteps(),
              style: Theme.of(context).textTheme.bodyText2,
          ),
        ),
        Padding(
          padding: EdgeInsets.symmetric(
            horizontal: getProportionateScreenWidth(20),
            vertical: 5,
          ),
          child: GestureDetector(
            onTap: () {},
            child: Row(
              children: [
                Text(
                  "Veja vídeo",
                  style: TextStyle(
                      fontWeight: FontWeight.w600, color: kPrimaryColor),
                ),
                SizedBox(width: 5),
                Icon(
                  Icons.keyboard_arrow_right,
                  size: 12,
                  color: kPrimaryColor,
                ),
              ],
            ),
          ),
        ),
      ],
    );
  }
}
