import 'package:alertapp/configurations/size_config.dart';
import 'package:flutter/material.dart';


class SectionTitle extends StatelessWidget {
  SectionTitle({
    Key? key,
    required this.title,
    required this.subtitle,
    required this.press,
  }) : super(key: key);

  final String title;
  final String subtitle;
  final GestureTapCallback press;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding:
      EdgeInsets.symmetric(horizontal: getProportionateScreenWidth(20)),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text(
            title,
            style: TextStyle(
              fontSize: getProportionateScreenWidth(18),
              color: Colors.black,
            ),
          ),
          GestureDetector(
            onTap: press,
            child: Text(
              subtitle,
              style: TextStyle(color: Color(0xFFBBBBBB)),
            ),
          ),
        ],
      ),
    );
  }
}
