import 'package:alertapp/configurations/size_config.dart';
import 'package:flutter/material.dart';

class CustomAppBar extends PreferredSize {
  final bool isFavorite;

  CustomAppBar(this.isFavorite)
      : super(preferredSize: Size(5, 5), child: Text('ola'));

  @override
  // AppBar().preferredSize.height provide us the height that appy on our app bar
  Size get preferredSize => Size.fromHeight(AppBar().preferredSize.height);

  @override
  Widget build(BuildContext context) {
    return SafeArea(
      child: Padding(
        padding:
            EdgeInsets.symmetric(horizontal: getProportionateScreenWidth(20), vertical: getProportionateScreenWidth(5),),
        child: Row(
          children: [
            SizedBox(
              height: getProportionateScreenWidth(40),
              width: getProportionateScreenWidth(40),
              child: ElevatedButton(
                style: ElevatedButton.styleFrom(
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(60),
                  ),
                  primary: Colors.white,
                  padding: EdgeInsets.zero,
                ),
                onPressed: () => Navigator.pop(context),
                child: Image.asset(
                  "assets/images/icons/left_arrow.png",
                  height: 15,
                ),
              ),
            ),
            Spacer(),
            Container(
              padding: const EdgeInsets.symmetric(horizontal: 14, vertical: 5),
              decoration: BoxDecoration(
                color: Colors.white,
                borderRadius: BorderRadius.circular(14),
              ),
              child: Row(
                children: [
                  Image.asset(
                    isFavorite
                        ? "assets/images/icons/stars.png"
                        : "assets/images/icons/star (2).png",
                    width: getProportionateScreenWidth(30),
                    height: getProportionateScreenWidth(30),
                  ),
                ],
              ),
            )
          ],
        ),
      ),
    );
  }
}
