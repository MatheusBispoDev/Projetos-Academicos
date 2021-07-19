import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/models/Stretche.dart';
import 'package:alertapp/screens/details/details_screen.dart';
import 'package:alertapp/screens/home/screetche_arguments.dart';
import 'package:alertapp/theme/constants.dart';
import 'package:flutter/material.dart';

class StretcheCard extends StatelessWidget {
  const StretcheCard({
    Key? key,
    this.width = 125,
    this.aspectRetio = 1.03,
    required this.stretche,
  }) : super(key: key);

  final double width, aspectRetio;
  final Stretches stretche;

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: EdgeInsets.only(left: getProportionateScreenWidth(20)),
      child: SizedBox(
        width: getProportionateScreenWidth(width),
        child: GestureDetector(
          onTap: () => Navigator.pushNamed(
            context,
            DetailsScreen.routeName,
            arguments: StretcheArguments(stretche),
          ),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              AspectRatio(
                aspectRatio: 1.03,
                child: Container(
                  padding: EdgeInsets.all(getProportionateScreenWidth(20)),
                  decoration: BoxDecoration(
                    color: kSecondaryColor.withOpacity(0.1),
                    borderRadius: BorderRadius.circular(15),
                  ),
                  child: Hero(
                    tag: stretche.name,
                    child: Image.asset(
                      stretche.image,
                      fit: BoxFit.cover,
                    ),
                  ),
                ),
              ),
              const SizedBox(height: 10),
              Text(
                stretche.name,
                style: TextStyle(color: Colors.black),
                maxLines: 2,
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceBetween,
                children: [
                  InkWell(
                    borderRadius: BorderRadius.circular(50),
                    onTap: () {},
                    child: Container(
                      padding: EdgeInsets.all(getProportionateScreenWidth(8)),
                      height: getProportionateScreenWidth(28),
                      width: getProportionateScreenWidth(28),
                      decoration: BoxDecoration(
                        color: stretche.isFavorite
                            ? kSecondaryColor.withOpacity(0.15)
                            : kSecondaryColor.withOpacity(0.1),
                        shape: BoxShape.circle,
                      ),
                      child: Image.asset(
                        stretche.isFavorite ?
                        "assets/images/icons/stars.png"
                            : "assets/images/icons/star (2).png",
                      ),
                    ),
                  ),
                ],
              )
            ],
          ),
        ),
      ),
    );
  }
}
