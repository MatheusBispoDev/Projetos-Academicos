import 'package:alertapp/configurations/size_config.dart';
import 'package:alertapp/models/Stretche.dart';
import 'package:alertapp/theme/constants.dart';
import 'package:flutter/material.dart';

class StretcheImages extends StatefulWidget {
  const StretcheImages({
    Key? key,
    required this.stretche,
  }) : super(key: key);

  final Stretches stretche;

  @override
  _StretcheImagesState createState() => _StretcheImagesState();
}

class _StretcheImagesState extends State<StretcheImages> {
  int selectedImage = 0;

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        SizedBox(
          width: getProportionateScreenWidth(238),
          child: AspectRatio(
            aspectRatio: 1,
            child: Hero(
              tag: widget.stretche.hashCode,
              child: Image.asset(widget.stretche.image),
            ),
          ),
        ),
        // SizedBox(height: getProportionateScreenWidth(20)),
        Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            ...List.generate(3, (index) => buildSmallProductPreview(index)),
          ],
        )
      ],
    );
  }

  GestureDetector buildSmallProductPreview(int index) {
    return GestureDetector(
      onTap: () {
        setState(() {
          selectedImage = index;
        });
      },
      child: AnimatedContainer(
        duration: defaultDuration,
        margin: EdgeInsets.only(right: 15),
        padding: EdgeInsets.all(8),
        height: getProportionateScreenWidth(48),
        width: getProportionateScreenWidth(48),
        decoration: BoxDecoration(
          color: Colors.white,
          borderRadius: BorderRadius.circular(10),
          border: Border.all(
              color: kPrimaryColor.withOpacity(selectedImage == index ? 1 : 0)),
        ),
        child: Image.asset(widget.stretche.image),
      ),
    );
  }
}
