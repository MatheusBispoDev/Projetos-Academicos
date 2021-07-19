import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/models/Stretche.dart';
import 'package:alertapp/theme/constants.dart';
import 'package:alertapp/widgets/rounded_icon_btn.dart';
import 'package:flutter/material.dart';

class ColorDots extends StatefulWidget {
  ColorDots({
    Key? key,
    required this.stretche,
  }) : super(key: key);

  final Stretches stretche;

  @override
  _ColorDotsState createState() => _ColorDotsState();
}

class _ColorDotsState extends State<ColorDots> {
  int selectedColor = 0;

  List<Color> colors = [
    kPrimaryLightColor,
    Color(0xFF836DB8),
    Color(0xFFF6625E),
    kPrimaryColor,
  ];

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding:
          EdgeInsets.symmetric(horizontal: getProportionateScreenWidth(20)),
      child: Row(
        children: [
          ...List.generate(
            colors.length,
            (index) => ColorDot(
              color: colors[index],
              isSelected: index == selectedColor,
              press: () {
                setState(() {
                  selectedColor = index;
                });
              },
            ),
          ),
          Spacer(),
          RoundedIconBtn(
            icon: Icons.remove,
            press: () {},
          ),
          SizedBox(width: getProportionateScreenWidth(20)),
          RoundedIconBtn(
            icon: Icons.add,
            showShadow: true,
            press: () {},
          ),
        ],
      ),
    );
  }
}

class ColorDot extends StatelessWidget {
  const ColorDot({
    Key? key,
    required this.color,
    required this.press,
    this.isSelected = false,
  }) : super(key: key);

  final Color color;
  final bool isSelected;
  final Function() press;

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: press,
      child: Container(
        margin: EdgeInsets.only(right: 2),
        padding: EdgeInsets.all(getProportionateScreenWidth(8)),
        height: getProportionateScreenWidth(40),
        width: getProportionateScreenWidth(40),
        decoration: BoxDecoration(
          color: Colors.transparent,
          border: Border.all(
              color: isSelected ? kPrimaryColor : Colors.transparent),
          shape: BoxShape.circle,
        ),
        child: DecoratedBox(
          decoration: BoxDecoration(
            color: color,
            shape: BoxShape.circle,
          ),
        ),
      ),
    );
  }
}
