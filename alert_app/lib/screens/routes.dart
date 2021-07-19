import 'package:alertapp/screens/home/home_screen.dart';
import 'package:alertapp/screens/profile/profile_screen.dart';
import 'package:alertapp/screens/splash/splash_screen.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'bottom_navegation/custom_bottom_nav_bar.dart';
//import 'details/details_screen.dart';

// We use name route
// All our routes will be available here
final Map<String, WidgetBuilder> routes = {
  SplashScreen.routeName: (context) => SplashScreen(),
  CustomNavBottom.routeName : (context) => CustomNavBottom(),
  HomeScreen.routeName: (context) => HomeScreen(),
  //DetailsScreen.routeName: (context) => DetailsScreen(),
  ProfileScreen.routeName: (context) => ProfileScreen(),
};
