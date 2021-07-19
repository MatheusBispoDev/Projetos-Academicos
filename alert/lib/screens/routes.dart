import 'package:alertapp/bottom_navegation/custom_bottom_nav_bar.dart';
import 'package:alertapp/screens/home/home_screen.dart';
import 'package:alertapp/screens/profile/profile_screen.dart';
import 'package:alertapp/screens/splash/splash_screen.dart';
import 'package:flutter/widgets.dart';

// We use name route
// All our routes will be available here
final Map<String, WidgetBuilder> routes = {
  SplashScreen.routeName: (context) => SplashScreen(),
  HomeScreen.routeName: (context) => HomeScreen(),
  ProfileScreen.routeName: (context) => ProfileScreen(),
  CustomNavBottom.routeName : (context) => CustomNavBottom(),
};
