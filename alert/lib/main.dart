import 'package:alertapp/bottom_navegation/custom_bottom_nav_bar.dart';
import 'package:alertapp/screens/routes.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(AlertApp());
}

class AlertApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {

    return MaterialApp(
      debugShowCheckedModeBanner: false,
      initialRoute: CustomNavBottom.routeName,
      routes: routes,
    );
  }
}
