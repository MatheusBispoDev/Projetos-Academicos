import 'package:alertapp/configurations/size_config.dart';
import 'package:flutter/material.dart';

class SectionTitle extends StatelessWidget {
  final String title;

  SectionTitle({required this.title});

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: EdgeInsets.symmetric(
          horizontal: getProportionateScreenWidth(20)),
      child: Text(
        title,
        style: TextStyle(
            fontSize: getProportionateScreenWidth(18),
            color: Colors.black),
      ),
    );
  }
}
