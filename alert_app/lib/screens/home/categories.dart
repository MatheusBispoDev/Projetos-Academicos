import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/theme/constants.dart';
import 'package:flutter/material.dart';

class Categories extends StatefulWidget {
  @override
  _CategoriesState createState() => _CategoriesState();
}

class _CategoriesState extends State<Categories> {

  int isSelected = 3;

  @override
  Widget build(BuildContext context) {
    List<Map<String, dynamic>> categories = [
      {
        "icon": "assets/images/iconsCategories/hand.png",
        "text": "Mãos",
        "isSelected": isSelected == 0 ? true : false
      },
      {
        "icon": "assets/images/iconsCategories/elbow.png",
        "text": "Braços",
        "isSelected": isSelected == 1 ? true : false
      },
      {
        "icon": "assets/images/iconsCategories/back.png",
        "text": "Costas",
        "isSelected": isSelected == 2 ? true : false
      },
      {
        "icon": "assets/images/iconsCategories/pain.png",
        "text": "Outros",
        "isSelected": isSelected == 3 ? true : false
      },
    ];
    return Padding(
      padding: EdgeInsets.all(getProportionateScreenWidth(35)),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        crossAxisAlignment: CrossAxisAlignment.start,
        children: List.generate(
          categories.length,
          (index) => CategoryCard(
            icon: categories[index]["icon"],
            text: categories[index]["text"],
            isSelected: categories[index]["isSelected"],
            press: () {
              setState(() {
                isSelected = index;
              });
            },
          ),
        ),
      ),
    );
  }
}

class CategoryCard extends StatelessWidget {
  const CategoryCard({
    Key? key,
    required this.icon,
    required this.text,
    required this.press,
    required this.isSelected,
  }) : super(key: key);

  final String icon, text;
  final bool isSelected;
  final GestureTapCallback press;

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: press,
      child: SizedBox(
        width: getProportionateScreenWidth(55),
        child: Column(
          children: [
            Container(
              padding: EdgeInsets.all(getProportionateScreenWidth(15)),
              height: getProportionateScreenWidth(55),
              width: getProportionateScreenWidth(55),
              decoration: BoxDecoration(
                color: isSelected ? kPrimaryColor : kPrimaryLightColor,
                borderRadius: BorderRadius.circular(10),
              ),
              child: Image.asset(icon,
                  color: isSelected ? Colors.white : Colors.black),
            ),
            SizedBox(height: 5),
            Text(
              text,
              textAlign: TextAlign.center,
              style:
                  TextStyle(color: isSelected ? kPrimaryColor : Colors.black),
            )
          ],
        ),
      ),
    );
  }
}
