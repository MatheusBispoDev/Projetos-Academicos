import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/models/LER.dart';
import 'package:alertapp/widgets/ler_card.dart';
import 'package:alertapp/widgets/section_title_card.dart';
import 'package:flutter/material.dart';

const String title = "LER's";
const String subtitle = "Veja todos";

class LerSection extends StatelessWidget {
  static String routeName = '/symptoms';

  @override
  Widget build(BuildContext context) {
    List<LER> lersList = LER.listLers;

    return Column(
      children: [
        SectionTitle(title: title, subtitle: subtitle, press: () {}),
        SizedBox(height: getProportionateScreenWidth(20)),
        SingleChildScrollView(
          scrollDirection: Axis.horizontal,
          child: Row(
            children: [
              ...List.generate(
                lersList.length,
                (index) {
                  return LERCard(
                    ler: lersList[index],
                    press: () {},
                  );
                },
              ),
              SizedBox(width: getProportionateScreenWidth(20)),
            ],
          ),
        )
      ],
    );
  }
}
