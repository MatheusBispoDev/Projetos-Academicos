import 'package:alertapp/screens/bottom_navegation/custom_bottom_nav_bar.dart';
import 'package:alertapp/screens/details/details_screen.dart';
import 'package:alertapp/screens/home/screetche_arguments.dart';
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
      onGenerateRoute: (settings) {
        if (settings.name == DetailsScreen.routeName) {
          final args = settings.arguments as StretcheArguments;
          return MaterialPageRoute(
            builder: (context) {
              return DetailsScreen(
                stretche: args.stretche,
              );
            },
          );
        }
      },
    );
  }
}