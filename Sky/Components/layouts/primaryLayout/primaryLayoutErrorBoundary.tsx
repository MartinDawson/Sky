import { withRouter } from "found";
import React from "react";
import { Container } from "rebass";
import { compose } from "recompose";

interface IProps {
  className?: string;
  children: React.ReactNode;
}

class PrimaryLayoutErrorBoundary extends React.Component<IProps> {
  // componentDidCatch() {
  //   this.props.router.push('/error/500');
  // }
  public render() {
    return (
      <Container>
        {this.props.children}
      </Container>
    );
  }
}

export default compose<IProps, IProps>(
  withRouter,
)(PrimaryLayoutErrorBoundary);
