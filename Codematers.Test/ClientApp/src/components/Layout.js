import React from "react";
import { Container } from "reactstrap";
import NavMenu from "./NavMenu";
import { PageFooter } from "./PageFooter";
import { HeroImage } from "./HeroImage";
export default props => (
  <React.Fragment>
    <NavMenu />
    <HeroImage />
    <Container>{props.children}</Container>
    <PageFooter />
  </React.Fragment>
);
