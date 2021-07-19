import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/models/Stretche.dart';
import 'package:alertapp/screens/home/stretche_card.dart';
import 'package:alertapp/widgets/section_title_card.dart';
import 'package:flutter/material.dart';

const String title = "Alongamentos";
const String subtitle = "Veja todos";

class StretchesSection extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    List<Stretches> stretchesList = Stretches.stretchesList;

    return Column(
      children: [
        SectionTitle(title: title, subtitle: subtitle, press: () {}),
        SizedBox(height: getProportionateScreenWidth(20)),
        SingleChildScrollView(
          scrollDirection: Axis.horizontal,
          child: Row(
            children: [
              ...List.generate(
                stretchesList.length,
                (index) {
                  return StretcheCard(
                    stretche: stretchesList[index],
                  );
                },
              ),
              SizedBox(width: getProportionateScreenWidth(20)),
            ],
          ),
        ),
      ],
    );
  }
}

