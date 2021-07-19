import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/widgets/icon_btn_with_counter.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:intl/date_symbol_data_local.dart';

class DiaryScreen extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    initializeDateFormatting('pt_BR', null);

    return Scaffold(
      body: SafeArea(
        child: SingleChildScrollView(
          child: Column(
            children: [
              SizedBox(height: getProportionateScreenHeight(30)),
              Row(
                children: [
                  HomeHeader(),
                ],
              )
            ],
          ),
        ),
      ),
    );
  }
}

class HomeHeader extends StatefulWidget {

  @override
  _HomeHeaderState createState() => _HomeHeaderState();
}

class _HomeHeaderState extends State<HomeHeader> {
  var dateString;

  _HomeHeaderState(){
    DateTime now = DateTime.now();
    dateString = DateFormat("MMMM").format(now);
  }

  @override
  Widget build(BuildContext context) {

    return Padding(
      padding:
          EdgeInsets.symmetric(horizontal: getProportionateScreenWidth(20)),
      child: SingleChildScrollView(
        child: Row(
          mainAxisAlignment: MainAxisAlignment.spaceBetween,
          children: [
            SizedBox(width: getProportionateScreenHeight(55)),
            IconBtnWithCounter(
              imageAsset: "assets/images/icons/left_arrow.png",
              press: () {
              },
            ),
            SizedBox(width: getProportionateScreenHeight(30)),
            Container(
                child: Text(
              '$dateString',
              style: Theme.of(context).textTheme.headline4,
            )),
            SizedBox(width: getProportionateScreenHeight(30)),
            IconBtnWithCounter(
              imageAsset: "assets/images/icons/next.png",
              press: () {
              },
            ),
          ],
        ),
      ),
    );
  }
}
