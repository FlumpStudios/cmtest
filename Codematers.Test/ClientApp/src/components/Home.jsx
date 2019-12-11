import React from "react";
import { connect } from "react-redux";
import { GridContainer } from "./GridContainer";

const style = {
  contents: {
     position:"absolute",
     bottom:"7%"
  }
};

const Home = props => (
  <div style={style.contents}>
    <GridContainer />
  </div>
);

export default connect()(Home);
